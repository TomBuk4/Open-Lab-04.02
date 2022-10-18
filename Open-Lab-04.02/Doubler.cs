{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string modify = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                modify = modify + original[i] + original[i];
            }
            return modify;
        }
    }
}
