using TinyTypesObjects;

namespace TinyTypesTest
{
    public class FirstName : TinyType<string>
    {
        public FirstName(string str) : base(str)
        {

        }
    }
}