interface IShape
{
    /* Return description of a shape.
       Examples: "Square[3x3]" where 3 is edge size of the square
                 "Circle[4]" where 4 is diameter of the circle
       */
    string Describe();

    /* Print to console the shape:

       ##
       ##

       will be printed for a Square with size == 2.

       ...
       ...
       ...

       will be printed for a Square with size == 3 that is transparent.

       For circles, print 'o' * diameter for non-transparent Circle,
       and '.' * diameter for transparent one.

       Example:
       ooooo

       circle with d == 5

       */
    void Print();

    /* Multiple size of a shape if the multiplier is positive number.
       In that case, true is returned. Otherwise, false is returned
       and the shape is unchanged. */
    bool MultiplySize(int multiplier);

    /* Get surface of the shape. Note the return type. */
    decimal Surface { get; }

    /* Get perimeter of the shape. Note the return type. */
    decimal Perimeter { get; }

    /* Property if object is transparent or not.
       By default an object is not transparent. */
    bool Transparent { get; set; }
}