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
namespace Authority
{
    public interface IObserverConnector<out TContext>
        where TContext : class
    {
        /// <summary>
        /// Connect an observer to the filter and/or pipe
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        ObserverHandle ConnectObserver(IFactObserver<TContext> observer);
    }


    public interface IObserverConnector
    {
        /// <summary>
        /// Connect an observer to the filter and/or pipe
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        ObserverHandle ConnectObserver<T>(IFactObserver<T> observer)
            where T : class;

        /// <summary>
        /// Connect an observer to the filter and/or pipe
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        ObserverHandle ConnectObserver(IFactObserver observer);
    }
}