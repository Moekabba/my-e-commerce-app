from __future__ import print_function
import json
import urllib
import boto
import datetime

print('Loading function...')

def process_refund(message, context):
    # Input Example 'key':'value'
    # {'Transaction': 'PURCHASE'}

    # 1. Log input message
    print("Received message from step Function:")
    print(message)

    # 2. Construct response object
    response = {}
    response['TransectionType'] = message['Transection']
    response['Timestamp'] = datetime.datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    response['Message'] = 'Hello from lambda land inside the ProcessReund function'

    return response