﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer.Plugins.Security.Authorization
{
    public interface IEmbeddedAuthorizationPolicy
    {
        void SerializeTo(IMutableImageUrl url);
        IEmbeddedAuthorizationPolicy DeserializeFrom(IImageUrl url);
        void RemoveFrom(IMutableImageUrl url);

        void FilterUrlForHashing(IMutableImageUrl url);
        IAuthorizationResult Authorize(IImageUrl url, IRequestEnvironment env);

    }
}