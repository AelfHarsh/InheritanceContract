using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace AElf.Contracts.CallerContract
{
    // The state class is access the blockchain state
    public partial class CallerContractState : ContractState 
    {
        // A state that holds string value
        public BoolState Initialized { get; set; }

         public StringState Message { get; set; }
    }
}