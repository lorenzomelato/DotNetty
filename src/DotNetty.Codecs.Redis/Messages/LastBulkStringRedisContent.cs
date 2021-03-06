﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DotNetty.Codecs.Redis.Messages
{
    using DotNetty.Buffers;

    public sealed class LastBulkStringRedisContent : DefaultByteBufferHolder, ILastBulkStringRedisContent
    {
        public LastBulkStringRedisContent(IByteBuffer buffer)
            : base(buffer)
        { }

        public override IByteBufferHolder Copy()
        {
            IByteBuffer buffer = this.Content.Copy();
            return new LastBulkStringRedisContent(buffer);
        }

        public override IByteBufferHolder Duplicate()
        {
            IByteBuffer buffer = this.Content.Duplicate();
            return new LastBulkStringRedisContent(buffer);
        }

        public override string ToString() => $"{nameof(LastBulkStringRedisContent)}[content={this.Content}]";
    }
}
