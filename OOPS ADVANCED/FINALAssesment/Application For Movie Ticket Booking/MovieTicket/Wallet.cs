namespace MovieTicket
{
    /// <summary>
    /// Interface of Wallet 
    /// this is used to  tell , create wallet for every Customer and use it.
    /// </summary>
    public interface IWallet
    {
        //property
        public double WalletBalance { get; set; }
        // Method
        /// <summary>
        /// Recharge wallet Method  Declaration is done
        /// </summary>
        void RechargeWallet();
        
        

    }
}