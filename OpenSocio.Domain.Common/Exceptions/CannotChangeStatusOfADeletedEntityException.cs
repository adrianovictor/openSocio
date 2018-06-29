using System;
using OpenSocio.Common;

namespace OpenSocio.Domain.Common
{
    public class CannotChangeStatusOfADeletedEntityException : Exception
    {
        public CannotChangeStatusOfADeletedEntityException()
            : base(ErrorCode.CANNOT_CHANGE_THE_STATUS_OF_A_DELETED_ENTITY)
        {            
        }
    }
}