# coding: utf-8

"""
    Bybit API

    ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]    # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: support@bybit.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.linear_positions_api import LinearPositionsApi  # noqa: E501
from swagger_client.rest import ApiException


class TestLinearPositionsApi(unittest.TestCase):
    """LinearPositionsApi unit test stubs"""

    def setUp(self):
        self.api = swagger_client.api.linear_positions_api.LinearPositionsApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_linear_positions_my_position(self):
        """Test case for linear_positions_my_position

        Get my position list.  # noqa: E501
        """
        pass

    def test_linear_positions_set_auto_add_margin(self):
        """Test case for linear_positions_set_auto_add_margin

        Set auto add margin  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
