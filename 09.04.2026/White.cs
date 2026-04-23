namespace ClassWork{
    public abstract class White
    {
        protected string _input;
        protected static char[] _punc;


        static White()
        {
            _punc = ['.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/'];
        }


        public string Input => _input;


        protected White(string input)
        {
            _input = input;
        }


        public abstract void Review();
        public virtual void ChangeText(string text)
        {
            _input = text;
            Review();
        }

        protected string[] GetWords(string text)
        {
            //...

            return new string[0];
        }
    }
}