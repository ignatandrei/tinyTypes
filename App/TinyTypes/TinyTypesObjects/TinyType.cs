using System;

namespace TinyTypesObjects
{
    public class TinyType<T>:IEquatable<T>, IEquatable<TinyType<T>>
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
            if (arg == null)
                return default(T);

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
            
            if (obj is T)
            {
                var val = (T)obj;
                
                return AreEqual(val,this.t);
            }
            if (obj is TinyType<T>)
            {
                var tt = (TinyType<T>)obj;
                if (tt == null)
                    return false;

                return this.Equals(tt);
            }

            return false;
        }
        bool AreEqual(T t1, T t2)
        {
            if (ReferenceEquals(t1, t2))
                return true;
            //var def = default(T);
            
            return t1.Equals(t2);


        }
    public override int GetHashCode()
        {
            return t.GetHashCode();
        }
        public override string ToString()
        {
            return t?.ToString();
        }

        public bool Equals(TinyType<T> other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            
            return AreEqual(this.t, other.t);
            
        }

        #endregion
    }
}
