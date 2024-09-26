using AElf.Contracts.BaseContract;
using AElf.Sdk.CSharp;
using AElf.Types;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.CallerContract
{
    public class CallerContract : CallerContractContainer.CallerContractBase
    {
        // Method to set the parent contract address
        public override Empty SetParentContractAddress(StringValue input)
        {
            // Convert the string input to an Address type and store it in the state
            
            State.ParentContractAddress.Value = Address.FromBase58(input.Value);
            return new Empty();
        }

        // Method to call the Initialize function of the parent contract
        public override Empty CallInitialize(Empty input)
        {
            Assert(State.ParentContractAddress.Value != null, "Parent contract address is not set.");
            
            State.BaseContract.value = "xHWrTizoqvW9abbwVdmWPGnxHihu7RKZDuEKyywLWpGwNATqH";
            var result = Context.Call<Empty>(State.ParentContractAddress.Value, nameof(BaseContractContainer.BaseContractBase.Initialize), input);
            return result;
        }

        // Method to call the GetStoredValue function of the parent contract
        public override Int32Value CallGetStoredValue(Empty input)
        {
            Assert(State.ParentContractAddress.Value != null, "Parent contract address is not set.");
            
            // Calling the GetStoredValue function of the parent contract
            var result = Context.Call<Int32Value>(State.ParentContractAddress.Value, nameof(BaseContractContainer.BaseContractBase.GetStoredValue), input);
            return result;
        }

        // Method to call the SetStoredValue function of the parent contract
        public override Empty CallSetStoredValue(Int32Value input)
        {
            Assert(State.ParentContractAddress.Value != null, "Parent contract address is not set.");
            
            // Calling the SetStoredValue function of the parent contract
            var result = Context.Call<Empty>(State.ParentContractAddress.Value, nameof(BaseContractContainer.BaseContractBase.SetStoredValue), input);
            return result;
        }
    }
}
