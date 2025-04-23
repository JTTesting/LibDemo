namespace LibDemo
{
    public class LibClass
    {
        private string _message;
        public LibClass(string message) 
        {
            _message = message;
        }
        public string GetMessage()
        {
            return $"{_message} from library and Package 6 with Brian and Dave";
        }
    }
}
