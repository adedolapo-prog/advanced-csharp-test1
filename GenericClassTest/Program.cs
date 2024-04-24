namespace GenericClassTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class valueConstraintClass<T> where T: struct
    {
        private List<T> _valueList;

        public void add(T value) {
            _valueList.Add(value);
        }

        public T getSingleValue(int index)
        {
            return _valueList[index];
        }

        public IEnumerable<T> getValuesInDescOrder() {
            return _valueList.OrderByDescending(x => x);
        }
    }
}
