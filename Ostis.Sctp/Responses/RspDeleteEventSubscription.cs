﻿using Ostis.Sctp.CallBacks;
using Ostis.Sctp.Arguments;
using System;

namespace Ostis.Sctp.Responses
{
    public class RspDeleteEventSubscription:AResponse
    {
        private SubScriptionId _id=new SubScriptionId();

        public SubScriptionId IDofSubscribe
        {
            get
            {
                if (base.Header.ReturnCode == enumReturnCode.Successfull)
                {
					_id.ID=BitConverter.ToInt32(base.BytesStream, base.Header.Leight);
                    
				}

                return _id;
            }
        }


		public RspDeleteEventSubscription(byte[] bytesstream)
            : base(bytesstream)
        {
            
        }

     
    }
}
