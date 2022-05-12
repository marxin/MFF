using System;

Tetris game = new();



game.AddShapeWithInteraction(game.Shapes[1], 8);
game.AddShapeWithInteraction(game.Shapes[0], 8);
game.AddShapeWithInteraction(game.Shapes[0], 8);

for (int i = 0; i < Tetris.WIDTH; i++)
    game.AddShapeWithInteraction(game.Shapes[2], i);

for (int i = 0; i < Tetris.HEIGHT + 5; i++)
    game.AddShapeWithInteraction(game.Shapes[2], 5);