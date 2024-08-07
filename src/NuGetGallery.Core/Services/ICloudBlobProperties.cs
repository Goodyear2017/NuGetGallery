﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace NuGetGallery
{
    public interface ICloudBlobProperties
    {
        DateTimeOffset? LastModified { get; }
        long Length { get; }
        string ContentType { get; set; }
        string ContentEncoding { get; set; }
        string CacheControl { get; set; }
        string ContentMD5 { get; }
    }
}
