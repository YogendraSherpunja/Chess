namespace ChessLogic
{
    public class Position
    {

        // two properties for rows and column 
        // property name should be in capital 
        public int Row { get; }

        public int Column { get; }

        // adding constructor 

        public Position(int row, int column) {
            {
                // store in property 
                Row = row;
                Column = column;

            } 

        
        }

        public Player SquareColor()
        {
            // sum of rows and column to determine white and black color 
            if((Row+Column)%2 == 0)
            {
                return Player.White;
            }

            return Player.Black;
        }

        //Equals checks if two Position objects have the same Row and Column.
        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }


        //GetHashCode ensures that objects with the same values have the same hash.
        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }


        //== and != operators allow you to compare Position objects directly using == and !=.
        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        //== and != operators allow you to compare Position objects directly using == and !=.
        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        public static Position operator +(Position pos, Direction dir)
        {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}
