namespace FizzBuzz
{
    public interface IRule
    {
        bool Applies(int number);
        void Print();
    }
}