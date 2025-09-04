namespace Notepad
{
    public class Tools : ITools
    {
        public string[] Temp { get; set; }
        public int Index { get; set; }
        public int CurrentPossiotion { get; set; }

        public Tools()
        {
            Temp = new string[200];
            Index = 0;
            CurrentPossiotion = 0;
        }
        public void Insert(string str)
        {
            Temp[Index] = str;
            CurrentPossiotion = Index;
            Index++;
        }

        public string Redo()
        {
            if (CurrentPossiotion < Index)
            {
                return Temp[++CurrentPossiotion];
            }
            return null;
        }

        public string Undo()
        {
            if (CurrentPossiotion > 0)
            {
                return Temp[--CurrentPossiotion];
            }
            return null;
        }
    }
}
