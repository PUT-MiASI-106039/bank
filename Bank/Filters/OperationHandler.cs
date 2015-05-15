namespace Bank.Filters
{
    public abstract class OperationHandler
    {
        protected OperationHandler Successor;

        public void SetSuccessor(OperationHandler successor)
        {
            Successor = successor;
        }

        public abstract void HandleRequest(object request);
    }
}
