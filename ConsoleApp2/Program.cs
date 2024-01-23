namespace ConsoleApp2
{
    class PublisherClass//Publisher Class
    {
        // Declare Delegate
        public delegate void MyDelegate(string msg);
        // Declaring Event
        public event MyDelegate myevent;


        public void displayMessageO()
        {
            myevent.Invoke("Welcome to India");// Raise event
        }

        class Program //Subscriber Class
        {
            //Event handler
            //Delegate call this method when event raised

            static void message(string str)
            {
                Console.WriteLine(str);
            }
            static void Main(string[] args)
            {
                PublisherClass obj = new PublisherClass();
                // Event gets binded with delegate
                obj.myevent += new PublisherClass.MyDelegate(message);
                obj.displayMessageO();
            }
        }

    }
}

