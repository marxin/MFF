using System;

Tetris game = new();

// add some shapes
game.AddShapeWithInteraction(game.Shapes[2], 7);
game.AddShapeWithInteraction(game.Shapes[0], 7);
game.AddShapeWithInteraction(game.Shapes[2], 7);

// cover entire line
for (int i = 0; i < Tetris.WIDTH; i++)
    game.AddShapeWithInteraction(game.Shapes[0], i);

// make a random game
var random = new Random(12345);

while(true)
{
    var shape = game.Shapes[random.Next(0, game.Shapes.Length)];
    var x = random.Next(0, Tetris.WIDTH - shape.Width);
    game.AddShapeWithInteraction(shape, x);
}