export class Orders {
    public  orderId : number;
	public vendorId : number;
	public customerId : number;
	public menuId : number;
	public walletId : number;
	public orderDate : Date;
	public quantityOrdered : number;
	public orderStatus : string;
	public billAmount : number;
	public orderComments : string;
    constructor() {

    }
}
