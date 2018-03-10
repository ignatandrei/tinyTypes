using System;

namespace TinyTypesObjects
{
    public class TinyType<T>:IEquatable<T>
    {
        //#region comparable null object
        //static T NullObject = new TinyType<T>();
        //private bool IsNullObject(TinyType<T> a)
        //{
        //    return a.t.Equals(this.t);
        //}
        //#endregion

        internal T t;
        public TinyType(T tDef)
        {
            t = tDef;
        }
        public TinyType() : this(default(T))
        {

        }
        public T value
        {
            get
            {
                return this.t;
            }
        }
        public static implicit operator T(TinyType<T> arg)
        {
            return arg.t;
        }
        public static implicit operator TinyType<T>(T arg)
        {
            //if arg==default
            return new TinyType<T>(arg);
        }
        #region equality
        public bool Equals(T other)
        {
            var def = default(T);
            if (other.Equals(def) && this.t.Equals(def))
                return true;
            return other.Equals(this.t);

        }
        public override bool Equals(object obj)
        {
            var def = default(T);
            try
            {
                var val = (T)obj;

                if (val == null && this.t.Equals(def))
                    return true;
                if (val.Equals(this.t))
                    return true;
            }
            catch
            {
                //do not log, maybe is not T
            }
            try
            {
                var tt = (TinyType<T>)obj;

                return this.Equals(tt);
            }
            catch
            {
                //do not log, maybe is not T
            }
            return false;
        }
        public override int GetHashCode()
        {
            return t.GetHashCode();
        }
        public override string ToString()
        {
            return t.ToString();
        }
        #endregion
    }
}
