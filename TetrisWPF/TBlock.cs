namespace TetrisWPF
{
    public class TBlock : Block
    {
        private readonly Position[][] _tiles =
        [
            [new(0, 1), new(1, 0), new(1, 1), new(1, 2)],
            [new(0, 1), new(1, 1), new(1, 2), new(2, 1)],
            [new(1, 0), new(1, 1), new(1, 2), new(2, 1)],
            [new(0, 1), new(1, 0), new(1, 1), new(2, 1)]
        ];

        public override GridValue ID => GridValue.Purple;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => _tiles;
    }
}
