using System;

namespace TinyTypesObjects
{
    public class TinyType<T>
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
        public static implicit operator T(TinyType<T> arg)
        {
            return arg.t;
        }
        

    }
}
