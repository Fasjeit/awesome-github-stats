﻿using AwesomeGithubStats.Core.Models;
using System.IO;

namespace AwesomeGithubStats.Models
{
    public class UserStatsSvg
    {
        private readonly UserRank _rank;
        private readonly string _file;

        public UserStatsSvg(UserRank rank, string file)
        {
            _rank = rank;
            _file = file;
        }

        public Stream Svg()
        {
            MemoryStream inMemoryCopy = new MemoryStream();
            using FileStream fs = File.OpenRead(_file);
            fs.CopyTo(inMemoryCopy);

            return fs;
        }
    }
}