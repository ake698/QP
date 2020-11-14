namespace QP.Bussiness
{
    public class PlayInfoDto : FullDto
    {
        public int BasicInfoId { get; set; }
        public int ResourceId { get; set; }
        public string Kuyun { get; set; }
        public string Mp4 { get; set; }

        public string[] PlayAddresses => Kuyun.Split("#");
    }

    public class PlayAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public PlayAddress NextNode { get; set; }
        public PlayAddress LastNode { get; set; }


        public static PlayAddress SplitSource(string source)
        {
            var sources = source.Split("#");
            PlayAddress root = null;
            PlayAddress address = null;
            PlayAddress cur = null;
            for (int i = 0; i < sources.Length; i++)
            {
                address = new PlayAddress();
                if (i != 0)
                {
                    address.LastNode = cur;
                    cur.NextNode = address;
                }
                else
                    root = address;
                cur = address;
                var infos = sources[i].Split("$");
                address.Name = infos[0];
                address.Address = infos[1];
            }
            return root;
        }
    }
}
