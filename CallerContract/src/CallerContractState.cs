using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace AElf.Contracts.CallerContract
{
    public class CallerContractState : ContractState
    {
        // Store the parent contract's address
        public SingletonState<Address> ParentContractAddress { get; set; }
    }
}
