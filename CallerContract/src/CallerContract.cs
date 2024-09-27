using AElf.Contracts.BaseContract;
using AElf.Sdk.CSharp;
using Google.Protobuf.WellKnownTypes;
using AElf.Types;

namespace AElf.Contracts.CallerContract
{
    // Contract class must inherit the base class generated from the proto file
    public class CallerContract : CallerContractContainer.CallerContractBase
    {
        // A method that modifies the contract state
        public override Empty Initialize(Empty input)
        {
            State.BaseContract.Value = Address.FromBase58("xHWrTizoqvW9abbwVdmWPGnxHihu7RKZDuEKyywLWpGwNATqH");
            State.BaseContract.Initialize.Send(input: new Empty());
            return new Empty();
        }
        public override Empty CallInitialize(Empty input)
        {
            Assert(State.BaseContract.Value != null, "Parent contract address is not set.");
            
            // Calling the Initialize function of the parent contract
            var result = Context.Call<Empty>(State.BaseContract.Value, nameof(BaseContractContainer.BaseContractReferenceState.Initialize), input);
            return result;
        }

        // Method to call the GetStoredValue function of the parent contract
        public override Int32Value CallGetStoredValue(Empty input)
        {
            Assert(State.BaseContract.Value != null, "Parent contract address is not set.");
            
            // Calling the GetStoredValue function of the parent contract
            var result = Context.Call<Int32Value>(State.BaseContract.Value, nameof(BaseContractContainer.BaseContractReferenceState.GetStoredValue), input);
            return result;
        }

        // Method to call the SetStoredValue function of the parent contract
        public override Empty CallSetStoredValue(Int32Value input)
        {
            Assert(State.BaseContract.Value != null, "Parent contract address is not set.");
            
            // Calling the SetStoredValue function of the parent contract
            var result = Context.Call<Empty>(State.BaseContract.Value, nameof(BaseContractContainer.BaseContractReferenceState.SetStoredValue), input);
            return result;
        }
    }
    
}