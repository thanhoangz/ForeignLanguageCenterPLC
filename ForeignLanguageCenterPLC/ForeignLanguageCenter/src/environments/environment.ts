// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  issuer: 'http://localhost:5000',
  imageDomain: 'http://192.168.1.6:8900',
  catalogServicesDomain: 'http://10.159.13.195:8080',
  orderServicesDomain: 'http://10.159.13.195:8081',
  paymentServicesDomain: 'http://10.159.13.195:8082',
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
