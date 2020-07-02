using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class PrimaryKeysValueList : Dictionary<string, object>
    {
        public override int GetHashCode()
        {
            int hcode = 0;

            foreach (var pair in this)
            {
                if (pair.Value == null)
                    throw new ArgumentNullException(pair.Key);

                else
                    hcode ^= pair.Value.GetHashCode();
            }

            return hcode.GetHashCode();
        }

        public class EqualityComparer : IEqualityComparer<PrimaryKeysValueList>
        {
            public static readonly EqualityComparer Default = new EqualityComparer();

            public EqualityComparer() : this(true) { }

            private bool _nullEqualsNull;

            public EqualityComparer(bool nullEqualsNull)
            {
                _nullEqualsNull = nullEqualsNull;
            }

            public bool Equals(PrimaryKeysValueList x, PrimaryKeysValueList y)
            {
                if (x == null && y == null)
                    return true;

                if (x == null || y == null)
                    return false;

                foreach (var pair in x)
                {
                    var valueX = pair.Value;
                    var valueY = y[pair.Key];

                    if (!_nullEqualsNull)
                        if (valueX == null || valueY == null)
                            return false;

                    if (!object.Equals(valueX, valueY))
                        return false;
                }

                return true;
            }

            public int GetHashCode(PrimaryKeysValueList obj)
            {
                int hcode = 0;

                foreach (var pair in obj)
                {
                    if (pair.Value == null)
                        throw new ArgumentNullException(pair.Key);
                    else
                        hcode ^= pair.Value.GetHashCode();
                }
                return hcode.GetHashCode();
            }
        }
    }
}
