using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTracker.Areas.PhotoManager
{
    public interface IPhotoManager
    {
        void UploadImageAsync(IFormFile file);
    }
}
