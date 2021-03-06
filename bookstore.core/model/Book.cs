namespace bookstore.core.model
{
    using utils;
    using validation;

    /// <summary>
    /// 书本
    /// </summary>
    public class Book : Validatable
    {

        public bool isValid()
        {
            if(this.Name.isNullOrEmpty()){
                return false;
            }

            return true;
        }

        public void verify()
        {
            throw new System.NotImplementedException();
        }

        public string Name { get; }
    }
}