using Google.Protobuf.WellKnownTypes;


namespace AElf.Contracts.BaseContract
{
    public class BaseContract : BaseContractContainer.BaseContractBase
    {
        // A method that modifies the contract state
       public override Empty Initialize(Empty input)
        {
            State.ValueToStore.Value = 0;
            return new Empty();
        }

        public override Int32Value GetStoredValue(Empty input)
        {
            return new Int32Value { Value = State.ValueToStore.Value };
        }

        public override Empty SetStoredValue(Int32Value input)
        {
            State.ValueToStore.Value = input.Value;
            return new Empty();
        }
    }
    
}