/** @type {import('next').NextConfig} */

module.exports = {
    images: {
        remotePatterns: [
            {
                protocol: 'https',
                hostname: 'swapshastorage.blob.core.windows.net',
                port: '',
                pathname: '/**',
            },
        ],
    },
}