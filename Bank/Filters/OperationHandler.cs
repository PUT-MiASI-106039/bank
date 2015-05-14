namespace Bank
{
    public abstract class OperationHandler
    {
        protected OperationHandler _successor;

        public void SetSuccessor(OperationHandler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(object request);
    }
}
