namespace DesignPattern.Pattern.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject); 
    }
}