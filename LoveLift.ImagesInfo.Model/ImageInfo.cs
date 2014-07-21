using LoveLift.ContentInfo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLift.ImagesInfo.Model
{
    [Serializable()]
    public class ImageInfo
    {
        private string imageID;

        public string ImageID
        {
            get { return imageID; }
            set { imageID = value; }
        }

        private string iamgeName;

        public string IamgeName
        {
            get { return iamgeName; }
            set { iamgeName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private DateTime createTime;

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private Content contentDto;

        public Content ContentDto
        {
            get { return contentDto; }
            set { contentDto = value; }
        }
    }
}
