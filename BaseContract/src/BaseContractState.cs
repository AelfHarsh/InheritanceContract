using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace AElf.Contracts.BaseContract
{
    // The state class is access the blockchain state
    public class BaseContractState : ContractState 
    {
        // A state that holds string value
       public Int32State ValueToStore { get; set; }
    }
}