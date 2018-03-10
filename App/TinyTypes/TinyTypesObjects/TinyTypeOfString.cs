namespace TinyTypesObjects
{
    public class TinyTypeOfString : TinyType<string>
        
    {
        public TinyTypeOfString(string tDef) : base(tDef)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(TinyTypeOfString lhs, TinyTypeOfString rhs)
        {
            if (lhs is null)
            {
                return rhs is null;
            }
            return lhs.t.Equals(rhs.t);
        }

        public static bool operator !=(TinyTypeOfString lhs, TinyTypeOfString rhs)
        {
            return !(lhs == rhs);
        }
        public static implicit operator string(TinyTypeOfString arg)
        {
            if (arg == null)
                return null;

            return arg.t;
        }
        public static implicit operator TinyTypeOfString(string arg)
        {

            return new TinyTypeOfString(arg);
        }
    }
}
