

using Event_Example;

BankAccount account = new BankAccount(); // amr bank ame amr kaje use korsi.
account.Aajira(); // amr eassa moto kaj korsi ame

// money deposit hola amake bolba
account.MoneyDeposited += () => { Console.WriteLine("Send notification to user."); };
// money deposit hola ame ae kaj ta korbo. ame akta notification send korbo r ki
// money deposit hola ame ae line ta print korbo tai ame seta event ar mordha raklam


account.Aajira(); // onno je kono ja hosse
account.Amni();

// akon money deposit hola notification jebe
// 2ta line print hosse dakho
account.Deposit();
// money deposit holo ae jonne Console.WriteLine("Send notification to user.") aetao print holo karon ame aeta event ar mordha raksilam.
// ame caile aro kisu event ar mordha rakte partam

// onno je kono kaj korle kintu notification send hobe na
account.Aajira(); 
account.Amni();
