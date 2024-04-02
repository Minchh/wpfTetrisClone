namespace TetrisWPF
{
    public class IBlock : Block
    {
        private readonly Position[][] _tiles =
        [
            [new(1, 0), new(1, 1), new(1, 2), new(1, 3)],
            [new(0, 2), new(1, 2), new(2, 2), new(3, 2)],
            [new(2, 0), new(2, 1), new(2, 2), new(2, 3)],
            [new(0, 1), new(1, 1), new(2, 1), new(3, 1)]
        ];

        public override GridValue ID => GridValue.Cyan;
        protected override Position StartOffset => new Position(-1, 3);
        protected override Position[][] Tiles => _tiles;
    }
}
