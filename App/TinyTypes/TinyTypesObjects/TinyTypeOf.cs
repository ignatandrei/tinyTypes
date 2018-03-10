namespace TinyTypesObjects
{
    public class TinyTypeOf<T> : TinyType<T>
        where T:struct
    {
        public TinyTypeOf(T tDef) : base(tDef)
        {
        }

       
        public static bool operator ==(TinyTypeOf<T> lhs, TinyTypeOf<T> rhs)
        {
            if(lhs is null)
            {
                return rhs is null;
            }
            return lhs.t.Equals(rhs.t);
        }

        public static bool operator !=(TinyTypeOf<T> lhs, TinyTypeOf<T> rhs)
        {
            return !(lhs==rhs);
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

        public static implicit operator T(TinyTypeOf<T> arg)
        {
            if (arg == null)
                return default(T);

            return arg.t;
        }
        public static implicit operator TinyTypeOf<T>(T arg)
        {
            
            return new TinyTypeOf<T>(arg);
        }
    }
}
