using System;


namespace R5T.Philippi
{
    public enum FileFormat
    {
        Unknown = 0,

        // Image-related.
        Bitmap = 1,
        Jpg = 2, // Also includes JPEG.
        Png = 3,

        Binary = 100,
        Data = 200,
        Temporary = 300,
        Text = 400,
    }
}
