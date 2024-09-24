using AElf.Cryptography.ECDSA;
using AElf.Testing.TestBase;

namespace AElf.Contracts.CallerContract
{
    // The Module class load the context required for unit testing
    public class Module : ContractTestModule<CallerContract>
    {
        
    }
    
    // The TestBase class inherit ContractTestBase class, it defines Stub classes and gets instances required for unit testing
    public class TestBase : ContractTestBase<Module>
    {
        // The Stub class for unit testing
        internal readonly CallerContractContainer.CallerContractStub CallerContractStub;
        // A key pair that can be used to interact with the contract instance
        private ECKeyPair DefaultKeyPair => Accounts[0].KeyPair;

        public TestBase()
        {
            CallerContractStub = GetCallerContractContractStub(DefaultKeyPair);
        }

        private CallerContractContainer.CallerContractStub GetCallerContractContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<CallerContractContainer.CallerContractStub>(ContractAddress, senderKeyPair);
        }
    }
    
}