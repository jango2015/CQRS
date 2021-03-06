﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Commands;
using Cqrs.Domain;

namespace MyCompany.MyProject.Domain.Authentication.Commands.Handlers
{

	[GeneratedCode("CQRS UML Code Generator", "1.601.786")]
	public  partial class UpdateUserCommandHandler
		
		: ICommandHandler<Cqrs.Authentication.ISingleSignOnToken, UpdateUserCommand>
	{
		protected IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> UnitOfWork { get; private set; }


		public UpdateUserCommandHandler(IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> unitOfWork)
		{
			UnitOfWork = unitOfWork;
		}

		#region Implementation of ICommandHandler<in UpdateUserCommand>

		public void Handle(UpdateUserCommand command)
		{
			User item = null;
			OnUpdateUser(command, ref item);
			if (item == null)
				item = UnitOfWork.Get<User>(command.Rsn);
			item.UpdateUser();
			OnUpdatedUser(command, item);
			OnCommit(command, item);
			UnitOfWork.Commit();
			OnCommited(command, item);
		}

		#endregion

		partial void OnUpdateUser(UpdateUserCommand command, ref User item);

		partial void OnUpdatedUser(UpdateUserCommand command, User item);

		partial void OnCommit(UpdateUserCommand command, User item);

		partial void OnCommited(UpdateUserCommand command, User item);
	}
}
