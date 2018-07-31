﻿using System;
namespace AuthorizeNet {

    //@deprecated since version 1.9.8  
    //@deprecated We have reorganized and simplified the Authorize.Net API to ease integration and to focus on merchants' needs.  
    //@deprecated We have deprecated AIM, ARB, CIM, and Reporting as separate options, in favor of AuthorizeNet::API.
    //@deprecated We have also deprecated SIM as a separate option, in favor of Accept Hosted. See https://developer.authorize.net/api/reference/features/accept_hosted.html for details on Accept Hosted.  
    //@deprecated For details on the deprecation and replacement of legacy Authorize.Net methods, visit https://developer.authorize.net/api/upgrade_guide/.   
    //@deprecated CP and CNP both use similar request structure (with differences in payment fields).   
    //@deprecated For CP, refer examples in https://github.com/AuthorizeNet/sample-code-php/tree/master/PaymentTransactions 
    [Obsolete("AuthorizeNetCP is deprecated, use AuthorizeNet::API instead. For CP, see examples in https://github.com/AuthorizeNet/sample-code-php/tree/master/PaymentTransactions.", false)]
    public interface ICardPresentGateway {
        AuthorizeNet.IGatewayResponse Send(AuthorizeNet.IGatewayRequest request, string description);
    }
}
