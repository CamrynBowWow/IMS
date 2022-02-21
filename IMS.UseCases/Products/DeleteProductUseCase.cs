﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository productRepository;

        public DeleteProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task ExecuteAsync(int productId)
        {
            await this.productRepository.DeleteProductAsync(productId);
        }

    }
}
