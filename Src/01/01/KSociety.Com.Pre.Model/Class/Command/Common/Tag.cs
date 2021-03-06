﻿using System.Threading;
using System.Threading.Tasks;
using KSociety.Com.Pre.Model.Interface.Command.Common;
using KSociety.Com.Srv.Agent;
using Microsoft.Extensions.Logging;

namespace KSociety.Com.Pre.Model.Class.Command.Common
{
    public class Tag : ITag
    {
        private readonly Srv.Agent.Command.Common.Tag _tag;

        public Tag(IComAgentConfiguration agentConfiguration, ILoggerFactory loggerFactory)
        {
            _tag = new Srv.Agent.Command.Common.Tag(agentConfiguration, loggerFactory);
        }

        public bool Remove(App.Dto.Req.Remove.Common.Tag removeItem, CancellationToken cancellationToken = default)
        {
            return _tag.Remove(removeItem);
        }

        public async ValueTask<bool> RemoveAsync(App.Dto.Req.Remove.Common.Tag removeCommonTag, CancellationToken cancellationToken = default)
        {
            return await _tag.RemoveAsync(removeCommonTag, cancellationToken);
        }

        public App.Dto.Res.Add.Common.Tag Add(App.Dto.Req.Add.Common.Tag addCommonTag, CancellationToken cancellationToken = default)
        {
            return _tag.Add(addCommonTag);
        }

        public App.Dto.Res.Update.Common.Tag Update(App.Dto.Req.Update.Common.Tag updateCommonTag, CancellationToken cancellationToken = default)
        {
            return _tag.Update(updateCommonTag);
        }

        public async ValueTask<App.Dto.Res.Update.Common.Tag> UpdateAsync(App.Dto.Req.Update.Common.Tag updateCommonTag, CancellationToken cancellationToken = default)
        {
            return await _tag.UpdateAsync(updateCommonTag, cancellationToken);
        }

        public App.Dto.Res.Copy.Common.Tag Copy(App.Dto.Req.Copy.Common.Tag copyCommonTag, CancellationToken cancellationToken = default)
        {
            return _tag.Copy(copyCommonTag);
        }

        public App.Dto.Res.Export.Common.Tag Export(App.Dto.Req.Export.Common.Tag exportItem, CancellationToken cancellationToken = default)
        {
            return _tag.Export(exportItem);
        }

        public App.Dto.Res.Import.Common.Tag Import(App.Dto.Req.Import.Common.Tag exportItem, CancellationToken cancellationToken = default)
        {
            return _tag.Import(exportItem);
        }

        public async ValueTask<App.Dto.Res.Add.Common.Tag> AddAsync(App.Dto.Req.Add.Common.Tag addCommonTag, CancellationToken cancellationToken = default)
        {
            return await _tag.AddAsync(addCommonTag, cancellationToken);
        }
        
        public async ValueTask<App.Dto.Res.Copy.Common.Tag> CopyAsync(App.Dto.Req.Copy.Common.Tag copyCommonTag, CancellationToken cancellationToken = default)
        {
            return await _tag.CopyAsync(copyCommonTag, cancellationToken);
        }

        public async ValueTask<App.Dto.Res.Export.Common.Tag> ExportAsync(App.Dto.Req.Export.Common.Tag exportItem, CancellationToken cancellationToken = default)
        {
            return await _tag.ExportAsync(exportItem, cancellationToken);
        }

        public async ValueTask<App.Dto.Res.Import.Common.Tag> ImportAsync(App.Dto.Req.Import.Common.Tag exportItem, CancellationToken cancellationToken = default)
        {
            return await _tag.ImportAsync(exportItem, cancellationToken);
        }

        public bool ModifyField(App.Dto.Req.ModifyField.Common.Tag modifyCommonTagField, CancellationToken cancellationToken = default)
        {
            return _tag.ModifyField(modifyCommonTagField);
        }
        
        public async ValueTask<bool> ModifyFieldAsync(App.Dto.Req.ModifyField.Common.Tag modifyCommonTagField, CancellationToken cancellationToken = default)
        {
            return await _tag.ModifyFieldAsync(modifyCommonTagField, cancellationToken);
        }
    }
}
