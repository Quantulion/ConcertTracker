using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IPhotoManager
    {
        void UploadImage(IFormFile file);
    }
}
