namespace GameOfLife.Writers
{
    public interface IWritable
    {
        void Write(bool[,] universe);

        bool[,] CurrentUniverse { get; set; }
    }
}
