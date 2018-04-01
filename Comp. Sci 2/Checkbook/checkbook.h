class Checkbook{

	public:
	void setBalance(float amount);
	bool writeCheck(float amount);

	void deposit(float amount);
	float getBalance();
	float getLastCheck();
	float getLastDeposit();

	private:
	float balance;
	float lastCheck;
	float lastDeposit;
};
