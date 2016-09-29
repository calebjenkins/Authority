﻿// Copyright 2012-2016 Chris Patterson
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Authority.Runtime
{
    public class SessionFactContext<T> :
        FactContext<T>
        where T : class
    {
        readonly SessionContext _sessionContext;

        public SessionFactContext(SessionContext sessionContext, T fact)
        {
            _sessionContext = sessionContext;

            Fact = fact;
        }

        public IWorkingMemory WorkingMemory => _sessionContext.WorkingMemory;

        public T Fact { get; }
    }
}