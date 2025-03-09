namespace ChessLogic
{
   public class Direction
    {
        // lets start with the north direction
        public static readonly Direction North = new Direction(-1, 0);
        public static readonly Direction South = new Direction(1, 0);
        public static readonly Direction East = new Direction(0, 1);
        public static readonly Direction West = new Direction(0, -1);
        // you can direction for diagonal moves 
        // use overloaded operators 
        public static readonly Direction NorthEast = North + East;
        public static readonly Direction NorthWest = North + West;
        public static readonly Direction SouthEast = South + East;
        public static readonly Direction SouthWest = South + West;


        // represent direction as a row delta or a column delta
        public int RowDelta { get; }
        public int ColumnDelta { get; }

        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }

        // add two direction together

        public static Direction operator +(Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);

        }

        // add multplication to scale a direction
        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction(scalar * dir.RowDelta, scalar * dir.ColumnDelta);
        }


    }
}
