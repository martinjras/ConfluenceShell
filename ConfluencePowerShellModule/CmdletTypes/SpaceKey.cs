namespace ConfluenceShell.CmdletTypes
{
    public class SpaceKey
    {
        private readonly string _key;

        internal SpaceKey(string key)
        {
            _key = key;
        }

        public static implicit operator SpaceKey(string value)
        {
            return new SpaceKey(value);
        }

        public static implicit operator string(SpaceKey value)
        {
            return value.ToString();
        }

        public override string ToString()
        {
            return _key;
        }
    }
}
