namespace sess04_classes_and_methods
{
    /// <summary>
    /// The Rect class will be used to create Rectangle objects
    /// </summary>
    public class Rect
    {
        private uint _length;
        private uint _width;

        public Rect()
        {
            this._length = 0;
            this._width = 0;    
        }

        public Rect(uint length, uint width)
        {
            this._length = length;
            this._width = width;
        }

        public uint GetLength() => this._length;
        public void SetLength(uint length) { this._length = length; }
        public uint GetWidth() => this._width;      
        public void SetWidth(uint width) { this._width = width; }
        public ulong CalcArea(){ return this._length * this._width; }
        public uint CalcPerimeter() { return 2* (this._length + this._width); }

        public override string ToString()
        {
            return $"Rectangle's Dimensions" +
                $"\n-----------------------------------" +
                $"\nLength: {this._length}" +
                $"\nWidth: {this._width}" +
                $"\nArea: {this.CalcArea()}" +
                $"\nPerimeter: {this.CalcPerimeter()}" +
                $"\n-----------------------------------\n";
        }
    }
}
